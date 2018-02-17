package outsystems.nosmusicdbexternaldata.records;

import java.io.Serializable;
import java.sql.*;
import java.math.BigDecimal;
import java.util.BitSet;
import org.w3c.dom.*;
import outsystems.objectkeys.*;
import outsystems.runtimecommon.*;
import outsystems.hubedition.runtimeplatform.*;
import outsystems.hubedition.runtimeplatform.db.*;
import outsystems.internal.db.*;
import outsystems.hubedition.databaseabstractionlayer.adoadapters.*;
import outsystems.hubedition.util.*;
import outsystems.hubedition.runtimeplatform.newruntime.*;
import outsystems.nosmusicdbexternaldata.records.*;

import outsystems.nosmusicdbexternaldata.entities.*;
import outsystems.nosmusicdbexternaldata.structures.*;
import outsystems.nosmusicdbexternaldata.recordlists.*;


public class RCt_CTContactRecord implements Serializable, Cloneable, ITypedRecord<RCt_CTContactRecord> {

	private static final GlobalObjectKey Idt_CTContact = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*T_HGtc7O9hv+IMdx_IFHxg");

	public static void ensureInitialized() {}
	public ENt_CTContactEntityRecord ssENt_CTContact;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_CTContactEntityRecord toStructure() {
		return ssENt_CTContact;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_CTContactRecord(ENt_CTContactEntityRecord r) throws Exception {
		ssENt_CTContact = (ENt_CTContactEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_CTContact.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_CTContact.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_CTContactRecord() {
		OptimizedAttributes = null;
		ssENt_CTContact = new ENt_CTContactEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(8, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_CTContact.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_CTContact.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_CTContact.OptimizedAttributes;
		return all;
	}

	/**
	 *
	 * Read a record from database
	 *
	 * @param  r
	 *         Data base reader
	 * @param  index
	 *         index
	 */
	public int read(OSResultSet r, int index) throws ClassCastException {
		index = ssENt_CTContact.read(r, index);
		return index;
	}
	/**
	 *
	 * Read from database
	 *
	 * @param  r
	 *         Data reader
	 */
	public void readDB(OSResultSet r) {
		int index = 0;
		read(r, index);
	}

	/**
	 *
	 * Read from record
	 *
	 * @param  r
	 *         Record
	 */
	public void readIM(RCt_CTContactRecord r) throws Exception {
		this.ssENt_CTContact = (ENt_CTContactEntityRecord) r.ssENt_CTContact.duplicate();
	}


	/**
	 *
	 * Comparison Function
	 *
	 * @param  obj
	 *         Object to compare to.
	 *
	 * @return  True if equal
	 */
	public boolean equals(Object obj) {
		if ((obj == null) || !(obj instanceof RCt_CTContactRecord)) {
			return false;
		}
		RCt_CTContactRecord b = (RCt_CTContactRecord) obj;
		if (!this.ssENt_CTContact.equals(b.ssENt_CTContact)) return false;
		return true;
	}

	/**
	 *
	 * Hash Value Function
	 *
	 * @return  A hash value for the instance
	 */
	public int hashCode() {
		try {
			return super.hashCode() ^ ssENt_CTContact.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_CTContact.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_CTContact.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_CTContactRecord duplicate() throws Exception {
		RCt_CTContactRecord t = new RCt_CTContactRecord();
		t.ssENt_CTContact = (ENt_CTContactEntityRecord) this.ssENt_CTContact.duplicate();
		t.OptimizedAttributes = null;
		return t;
	}

	public IRecord duplicate$IRecord() throws Exception {
		return duplicate();
	}
	public void toXml(Object parent, Element baseElem, String fieldName, int detailLevel) {
		Element recordElem = VarValue.appendChild(baseElem, "Record");
		if (fieldName != null) {
			VarValue.appendAttribute(recordElem, "debug.field", fieldName);
		}
		if (detailLevel > 0) {
			ssENt_CTContact.toXml(this, recordElem, "t_CTContact", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_ctcontact")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_CTContact")) variable.setValue(ssENt_CTContact); else variable.setOptimized(true);
			variable.setFieldName("t_ctcontact");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_CTContactRecord t = (RCt_CTContactRecord) super.clone();
		t.ssENt_CTContact = (ENt_CTContactEntityRecord) this.ssENt_CTContact.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_CTContact.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_CTContact.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_CTContact)) {
			return ssENt_CTContact;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_CTContact.fillFromOther((IRecord) other.attributeGet(Idt_CTContact));
	}
}
