package outsystems.nosmusicdbexternaldb.records;

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
import outsystems.nosmusicdbexternaldb.records.*;

import outsystems.nosmusicdbexternaldb.entities.*;
import outsystems.nosmusicdbexternaldb.structures.*;
import outsystems.nosmusicdbexternaldb.recordlists.*;


public class RCt_MUBandRecord implements Serializable, Cloneable, ITypedRecord<RCt_MUBandRecord> {

	private static final GlobalObjectKey Idt_MUBand = GlobalObjectKey.parse("2UmDmepsh0WSfJ_D1JexCA*B+t59G4FdyCYOnePx0hatA");

	public static void ensureInitialized() {}
	public ENt_MUBandEntityRecord ssENt_MUBand;


	/**
	 *
	 * Get Structure instance
	 *
	 * @return  The structure
	 */
	public ENt_MUBandEntityRecord toStructure() {
		return ssENt_MUBand;
	}

	/**
	 *
	 * Constructor
	 *
	 * @param  r
	 *         The base structure
	 */
	public RCt_MUBandRecord(ENt_MUBandEntityRecord r) throws Exception {
		ssENt_MUBand = (ENt_MUBandEntityRecord)
		r.clone();
	}

	public void setChangedAttributes(BitSet value) {
		ssENt_MUBand.ChangedAttributes = value;
	}
	public BitSet getChangedAttributes() {
		return ssENt_MUBand.ChangedAttributes;
	}
	public BitSet OptimizedAttributes;

	/**
	 *
	 * Default Constructor
	 */
	public RCt_MUBandRecord() {
		OptimizedAttributes = null;
		ssENt_MUBand = new ENt_MUBandEntityRecord();
	}

	public BitSet[] getDefaultOptimizedValues() {
		BitSet[] all = new BitSet[1];
		all[0] = BitSetUtils.newInstance(6, false);
		return all;
	}

	public void setAllOptimizedAttributes(BitSet[] value) {
		if (value == null) {
			ssENt_MUBand.OptimizedAttributes = getDefaultOptimizedValues()[0];
		} else {
			ssENt_MUBand.OptimizedAttributes = value[0];
		}
	}
	public BitSet[] getAllOptimizedAttributes() {
		BitSet[] all = new BitSet[1];
		all[0] = ssENt_MUBand.OptimizedAttributes;
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
		index = ssENt_MUBand.read(r, index);
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
	public void readIM(RCt_MUBandRecord r) throws Exception {
		this.ssENt_MUBand = (ENt_MUBandEntityRecord) r.ssENt_MUBand.duplicate();
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
		if ((obj == null) || !(obj instanceof RCt_MUBandRecord)) {
			return false;
		}
		RCt_MUBandRecord b = (RCt_MUBandRecord) obj;
		if (!this.ssENt_MUBand.equals(b.ssENt_MUBand)) return false;
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
			return super.hashCode() ^ ssENt_MUBand.hashCode();
		} catch (NullPointerException e) {
			return super.hashCode();
		}
	}

	/**
	 *
	 * Performs a Recursive Reset in the instance
	 */
	public void recursiveReset() throws Exception {
		ssENt_MUBand.recursiveReset();
	}

	/**
	 *
	 * Performs a internal Recursive Reset in the instance
	 */
	public void internalRecursiveSave() throws Exception {
		ssENt_MUBand.internalRecursiveSave();
	}

	/**
	 *
	 * Returns a duplicate/clone instance
	 *
	 * @return  Duplicate Instance
	 */
	public RCt_MUBandRecord duplicate() throws Exception {
		RCt_MUBandRecord t = new RCt_MUBandRecord();
		t.ssENt_MUBand = (ENt_MUBandEntityRecord) this.ssENt_MUBand.duplicate();
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
			ssENt_MUBand.toXml(this, recordElem, "t_MUBand", detailLevel - 1);
		} else {
			VarValue.appendDeferredEvaluationElement(recordElem);
		}
	}

	public void evaluateFields(VarValue variable, Object parent, String baseName, String fields) throws java.lang.reflect.InvocationTargetException, IllegalAccessException, IllegalArgumentException {
		String head = VarValue.getHead(fields);
		String tail = VarValue.getTail(fields);
		variable.setFound(false);
		if (head.equals("t_muband")) {
			if (!VarValue.fieldIsOptimized(parent, baseName + ".t_MUBand")) variable.setValue(ssENt_MUBand); else variable.setOptimized(true);
			variable.setFieldName("t_muband");
		}
		if (variable.isFound() && tail != null) variable.evaluateFields(this, head, tail);
	}

	public Object clone() throws CloneNotSupportedException {
		RCt_MUBandRecord t = (RCt_MUBandRecord) super.clone();
		t.ssENt_MUBand = (ENt_MUBandEntityRecord) this.ssENt_MUBand.clone();
		return t;
	}

	public boolean changedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUBand.changedAttributeGet(key);
	}

	public boolean optimizedAttributeGet(GlobalObjectKey key) throws Exception {
		return ssENt_MUBand.optimizedAttributeGet(key);
	}

	public Object attributeGet(GlobalObjectKey key) throws Exception {
		if (key.equals(Idt_MUBand)) {
			return ssENt_MUBand;
		} else {
			throw new Exception("Invalid key");
		}
	}
	public void fillFromOther(IRecord other) throws Exception {
		if (other == null) return;
		ssENt_MUBand.fillFromOther((IRecord) other.attributeGet(Idt_MUBand));
	}
}
