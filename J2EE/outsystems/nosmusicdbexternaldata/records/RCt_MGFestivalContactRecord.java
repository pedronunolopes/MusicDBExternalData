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


public class RCt_MGFestivalContactRecord implements Serializable, Cloneable, ITypedRecord<RCt_MGFestivalContactRecord> {

	private static final GlobalObjectKey Idt_MGFestivalContact = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*bA9P5SWioAbNa1aZA4u38w");

	public static void ensureInitialized() {}
	public ENt_MGFestivalContactEntityRecord ssENt_MGFestivalContact;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MGFestivalContactEntityRecord toStructure() {
		return ssENt_MGFestivalContact;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MGFestivalContactRecord(ENt_MGFestivalContactEntityRecord r) throws Exception {
		ssENt_MGFestivalContact = (ENt_MGFestivalContactEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MGFestivalContact.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MGFestivalContact.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MGFestivalContactRecord() {
		OptimizedAttributes = null;
		ssENt_MGFestivalContact = new ENt_MGFestivalContactEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(4, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MGFestivalContact.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MGFestivalContact.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MGFestivalContact.OptimizedAttributes;
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
		index = ssENt_MGFestivalContact.read(r, index);
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
	public void readIM(RCt_MGFestivalContactRecord r) throws Exception {
		this.ssENt_MGFestivalContact = (ENt_MGFestivalContactEntityRecord) r.ssENt_MGFestivalContact.duplicate();
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
		if ((obj == null) || !(obj instanceof RCt_MGFestivalContactRecord)) {
			return false;
		}
		RCt_MGFestivalContactRecord b = (RCt_MGFestivalContactRecord) obj;
		if (!this.ssENt_MGFestivalContact.equals(b.ssENt_MGFestivalContact)) return false;
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
			return super.hashCode() ^ ssENt_MGFestivalContact.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MGFestivalContact.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MGFestivalContact.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MGFestivalContactRecord duplicate() throws Exception {
		RCt_MGFestivalContactRecord t = new RCt_MGFestivalContactRecord();
		t.ssENt_MGFestivalContact = (ENt_MGFestivalContactEntityRecord) this.ssENt_MGFestivalContact.duplicate();
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
			ssENt_MGFestivalContact.toXml(this, recordElem, "t_MGFestivalContact", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_mgfestivalcontact")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MGFestivalContact")) variable.setValue(ssENt_MGFestivalContact); else variable.setOptimized(true);
			variable.setFieldName("t_mgfestivalcontact");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MGFestivalContactRecord t = (RCt_MGFestivalContactRecord) super.clone();
		t.ssENt_MGFestivalContact = (ENt_MGFestivalContactEntityRecord) this.ssENt_MGFestivalContact.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MGFestivalContact.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MGFestivalContact.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MGFestivalContact)) {
			return ssENt_MGFestivalContact;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MGFestivalContact.fillFromOther((IRecord) other.attributeGet(Idt_MGFestivalContact));
	}
}
